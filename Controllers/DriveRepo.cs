// using System;

// public class DriveRepo
// {
// 	public DriveRepo()
// 	{
//         var fileMetadata = new File()
//         {
//             Name = "photo.jpg"
//         };
//         FilesResource.CreateMediaUpload request;
//         using (var stream = new System.IO.FileStream("files/photo.jpg",
//                                 System.IO.FileMode.Open))
//         {
//             request = driveService.Files.Create(
//                 fileMetadata, stream, "image/jpeg");
//             request.Fields = "id";
//             request.Upload();
//         }
//         var file = request.ResponseBody;
//         Console.WriteLine("File ID: " + file.Id);

//     }
// }
