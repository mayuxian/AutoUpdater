public interface IUpdateException
{
    void CommunicationExceptionHandle();

    void DownloadFileExceptionHandle();

    void UnhandlePlatformExceptionHandle();
}