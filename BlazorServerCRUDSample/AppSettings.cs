namespace BlazorServerCRUDSample
{
    //appsettings.jsonからデータを取得する際に使用。どこからでも参照可能にする
    public static class AppSettings
    {
        public static IConfiguration Configuration { get; set; }
    }
}
