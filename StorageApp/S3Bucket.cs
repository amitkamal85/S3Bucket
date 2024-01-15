using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.S3.Model;
using Amazon.S3;
using Amazon;
using System.Collections.Specialized;
using System.IO;
namespace StorageApp
{
    public class S3Buckets
    {

        public string bucketName = "";
        public string accesskey = "";
        public string secretkey = "";
        public AmazonS3 GetAmazonS3Client()
        {


            AmazonS3 s3Client = AWSClientFactory.CreateAmazonS3Client(
              accesskey, secretkey

                    );
            return s3Client;
        }


        /// <summary>
        ///     Create a new bucket
        /// </summary>
        public void CreateBucket()
        {
            using (AmazonS3 s3Client = GetAmazonS3Client())
            {
                try
                {
                    PutBucketRequest putBucketRequest = new PutBucketRequest();
                    String newBucketName = bucketName;
                    putBucketRequest.BucketName = newBucketName;
                    PutBucketResponse putBucketResponse = s3Client.PutBucket(putBucketRequest);
                }
                catch (AmazonS3Exception e)
                {
                    Console.WriteLine("Bucket creation has failed.");
                    Console.WriteLine("Amazon error code: {0}",
                        string.IsNullOrEmpty(e.ErrorCode) ? "None" : e.ErrorCode);
                    Console.WriteLine("Exception message: {0}", e.Message);
                }
            }
        }


        /// <summary>
        /// Get All the buckets
        /// </summary>
        //public void GetAllBuckets()
        //{
        //    using (AmazonS3 s3Client = GetAmazonS3Client())
        //    {
        //        try
        //        {
        //            ListBucketsResponse response = s3Client.ListBuckets();
        //            List<S3Bucket> buckets = response.Buckets;
        //            foreach (S3Bucket bucket in buckets)
        //            {
        //                Console.WriteLine("Found bucket name {0} created at {1}", bucket.BucketName, bucket.CreationDate);
        //            }
        //        }
        //        catch (AmazonS3Exception e)
        //        {
        //            Console.WriteLine("Bucket listing has failed.");
        //            Console.WriteLine("Amazon error code: {0}",
        //                string.IsNullOrEmpty(e.ErrorCode) ? "None" : e.ErrorCode);
        //            Console.WriteLine("Exception message: {0}", e.Message);
        //        }
        //    }
        //}



        /// <summary>
        /// Download a file from bucket
        /// </summary>
        public GetObjectResponse DownloadFilesFromBucket(String path, String downloadPath)
        {
            using (AmazonS3 s3Client = GetAmazonS3Client())
            {
                GetObjectResponse getObjectResponse = new GetObjectResponse();
                try
                {
                    GetObjectRequest getObjectRequest = new GetObjectRequest();
                    getObjectRequest.BucketName = bucketName;
                    getObjectRequest.Key = path;
                    getObjectResponse = s3Client.GetObject(getObjectRequest);
                    String fileName = path.Substring(path.LastIndexOf("/"), path.Length - path.LastIndexOf("/")).Replace("/", "");
                    getObjectResponse.WriteResponseStreamToFile(downloadPath + "/" + fileName);



                    return getObjectResponse;
                }
                catch (AmazonS3Exception e)
                {
                    Console.WriteLine("Object download has failed.");
                    Console.WriteLine("Amazon error code: {0}",
                        string.IsNullOrEmpty(e.ErrorCode) ? "None" : e.ErrorCode);
                    Console.WriteLine("Exception message: {0}", e.Message);
                }
                return getObjectResponse;
            }
        }



        /// <summary>
        /// Create Folder
        /// </summary>
        public bool CreateFolder(String folderKey, string folderName)
        {
            using (AmazonS3 s3Client = GetAmazonS3Client())
            {
                try
                {
                    PutObjectRequest folderRequest = new PutObjectRequest();
                    String delimiter = "/";
                    folderRequest.BucketName = bucketName;
                     folderKey = folderKey+folderName+delimiter;
                    folderRequest.Key = folderKey;
                    folderRequest.InputStream = new MemoryStream(new byte[0]);
                    PutObjectResponse folderResponse = s3Client.PutObject(folderRequest);
                    return true;
                }
                catch (AmazonS3Exception e)
                {
                    Console.WriteLine("Folder creation has failed.");
                    Console.WriteLine("Amazon error code: {0}",
                        string.IsNullOrEmpty(e.ErrorCode) ? "None" : e.ErrorCode);
                    Console.WriteLine("Exception message: {0}", e.Message);
                    return false;
                }
            }
        }


        /// <summary>
        /// Check if Folder Exists
        /// </summary>
        public Boolean CheckfolderExistOrNot(String folderName)
        {
            Boolean folderExist = false;
            using (AmazonS3 s3Client = GetAmazonS3Client())
            {

                try
                {
                    ListObjectsRequest findFolderRequest = new ListObjectsRequest();
                    findFolderRequest.BucketName = bucketName;
                    findFolderRequest.Delimiter = "/";
                    findFolderRequest.Prefix = folderName;
                    ListObjectsResponse findFolderResponse = s3Client.ListObjects(findFolderRequest);
                    List<String> commonPrefixes = findFolderResponse.CommonPrefixes;
                    folderExist = commonPrefixes.Any();
                }
                catch (AmazonS3Exception e)
                {
                    Console.WriteLine("Folder existence check has failed.");
                    Console.WriteLine("Amazon error code: {0}",
                        string.IsNullOrEmpty(e.ErrorCode) ? "None" : e.ErrorCode);
                    Console.WriteLine("Exception message: {0}", e.Message);
                }

            }
            return folderExist;
        }




        /// <summary>
        /// Upload file to a folder
        /// </summary>
        public Boolean uploadFileTofolder(String uploadpath, String localfilePath)
        {

            using (AmazonS3 s3Client = GetAmazonS3Client())
            {
                try
                {


                    //String filePath = "C:\\Users\\Amit\\Desktop\\images.jpg";
                    FileInfo fi = new FileInfo(localfilePath);

                    MemoryStream ms = new MemoryStream(StreamFile(localfilePath));
                    FileInfo fs;

                    PutObjectRequest request = new PutObjectRequest();
                    request.WithBucketName(bucketName);
                    request.WithKey(uploadpath + fi.Name);
                    request.WithInputStream(ms);
                    // request.WithFilePath(filePath);
                    PutObjectResponse response2 = s3Client.PutObject(request);

                    return true;
                }
                catch (AmazonS3Exception e)
                {
                    Console.WriteLine("File creation within folder has failed.");
                    Console.WriteLine("Amazon error code: {0}",
                        string.IsNullOrEmpty(e.ErrorCode) ? "None" : e.ErrorCode);
                    Console.WriteLine("Exception message: {0}", e.Message);
                }
            }
            return false;
        }

        public byte[] StreamFile(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);

            // Create a byte array of file stream length
            byte[] ImageData = new byte[fs.Length];

            //Read block of bytes from stream into the byte array
            fs.Read(ImageData, 0, System.Convert.ToInt32(fs.Length));

            //Close the File Stream
            fs.Close();
            return ImageData; //return the byte data
        }
        /// <summary>
        /// GetFiles of a folder
        /// </summary>
        public ListObjectsResponse GetFilesInfoOffolder(String path)
        {
            using (AmazonS3 s3Client = GetAmazonS3Client())
            {
                ListObjectsRequest listObjectsRequest = new ListObjectsRequest();
                ListObjectsResponse listObjectsResponse = new ListObjectsResponse();
                try
                {

                    String delimiter = "/";
                    listObjectsRequest.BucketName = bucketName;
                    listObjectsRequest.Prefix = path;
                    listObjectsResponse = s3Client.ListObjects(listObjectsRequest);
                    //foreach (S3Object entry in listObjectsResponse.S3Objects)
                    //{
                    //    if (entry.Size > 0)
                    //    {
                    //        Console.WriteLine("Found object with key {0}, size {1}, last modification date {2}", entry.Key, entry.Size, entry.LastModified, entry);
                    //    }
                    //}
                }
                catch (AmazonS3Exception e)
                {
                    Console.WriteLine("File creation within folder has failed.");
                    Console.WriteLine("Amazon error code: {0}",
                        string.IsNullOrEmpty(e.ErrorCode) ? "None" : e.ErrorCode);
                    Console.WriteLine("Exception message: {0}", e.Message);
                }
                return listObjectsResponse;
            }
        }

        /// <summary>
        /// Delete folder or File
        /// </summary>
        public Boolean DeletefolderOrFile(String path)
        {
            using (AmazonS3 s3Client = GetAmazonS3Client())
            {
                try
                {
                    DeleteObjectRequest deleteFolderRequest = new DeleteObjectRequest();
                    deleteFolderRequest.BucketName = bucketName;
                    deleteFolderRequest.Key = path;
                    DeleteObjectResponse deleteObjectResponse = s3Client.DeleteObject(deleteFolderRequest);
                    return true;
                }
                catch (AmazonS3Exception e)
                {
                    Console.WriteLine("Folder deletion has failed.");
                    Console.WriteLine("Amazon error code: {0}",
                        string.IsNullOrEmpty(e.ErrorCode) ? "None" : e.ErrorCode);
                    Console.WriteLine("Exception message: {0}", e.Message);
                }

            }
            return false;
        }



        public bool CreateNewFolder(String rootFolder, String foldername)
        {

            using (AmazonS3 s3Client = GetAmazonS3Client())
            {
                try
                {


                    String S3_KEY = rootFolder + foldername;
                    PutObjectRequest request = new PutObjectRequest();
                    request.WithBucketName(bucketName);
                    request.WithKey(S3_KEY);
                    request.WithContentBody("");
                    s3Client.PutObject(request);
                    AddEmptyFileInFolder(s3Client, S3_KEY);
                }
                catch (AmazonS3Exception e)
                {
                    Console.WriteLine("Folder deletion has failed.");
                    Console.WriteLine("Amazon error code: {0}",
                        string.IsNullOrEmpty(e.ErrorCode) ? "None" : e.ErrorCode);
                    Console.WriteLine("Exception message: {0}", e.Message);
                }

            }
            return false;


        }


        public void AddEmptyFileInFolder(AmazonS3 client, String path)
        {
            String S3_KEY = path + "/" + "Empty.txt";
            PutObjectRequest request = new PutObjectRequest();
            request.WithBucketName(bucketName);
            request.WithKey(S3_KEY);
            request.WithContentBody("Empty Object.");
            client.PutObject(request);
        }



        public String MakeUrl(AmazonS3 s3Client, String key)
        {
            string preSignedURL = s3Client.GetPreSignedURL(new GetPreSignedUrlRequest()
            {
                BucketName = bucketName,
                Key = key,
                Expires = System.DateTime.Now.AddMinutes(30)

            });

            return preSignedURL;
        }




    }
}
