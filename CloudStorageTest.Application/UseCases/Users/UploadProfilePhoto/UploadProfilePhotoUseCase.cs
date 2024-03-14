using CloudStorageTest.Domain.Entities;
using CloudStorageTest.Domain.Storage;
using FileTypeChecker.Extensions;
using FileTypeChecker.Types;
using Microsoft.AspNetCore.Http;

namespace CloudStorageTest.Application.UseCases.Users.UploadProfilePhoto;

public class UploadProfilePhotoUseCase : IUploadProfilePhotoUseCase
{
    private readonly IStorageService _storageService;

    public UploadProfilePhotoUseCase(IStorageService storageService)
    {
        _storageService = storageService;    
    }

    public void Execute(IFormFile file)
    {
        var fileStream = file.OpenReadStream();

        var isImage = fileStream.Is<JointPhotographicExpertsGroup>();

        if (isImage == false)
            throw new Exception("The file is not an image.");

        var user = GetFromDataBase();

        _storageService.Upload(file, user);
    }

    private User GetFromDataBase()
    {
        return new User
        {
            Id = 1,
            Name = "Test",
            Email = "test123@gmail.com",
            RefreshToken = "",
            AccessToken = ""
        };
    }
}
