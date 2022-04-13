# BlazorServerCRUDSample

Blazor ServerのCRUDアプリのサンプル

## Databaseの接続先について

appsettings.jsonのConnectionStringをご自身の環境のSQL Serverに接続先を変更してください。  
SQL Serverの利用を前提にEntityFrameworkで実装していますので、他のDBを利用される場合は、
適宜実装を変更してください。

## Databaseの初期化

パッケージマネージャーコンソールで

```
Update-Database
```

を実行してください。
DBの作成及び、サンプルデータが作成されます。
