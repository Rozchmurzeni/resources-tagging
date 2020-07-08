# resources-tagging
Sample app showing how to tag resources in AWS.

There are implemented two types of tagging resources:
- tags in CloudFormation file - deploy-app-cf-level.ps1
- stack-level tags - tags are defined in deploy file, no tags in the CloudFormation file - deploy-app-stack-level.ps1

Additionally it's worth to look at tool prepared by Lumigo - [SAR-Propagate-CFN-Tags](https://github.com/lumigo-io/SAR-Propagate-CFN-Tags)

Used resources:
- Lambda
- SQS
- LogGroups
- StepFunctions