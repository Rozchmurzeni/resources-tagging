dotnet lambda deploy-serverless `
    --configuration Release `
    --region eu-west-1 `
    --stack-name resources-tagging-app `
    --s3-bucket nth-deploy-sand `
    --s3-prefix resources-tagging/ `
    --template application.yaml;