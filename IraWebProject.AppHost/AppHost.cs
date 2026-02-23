var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.IraWebProject>("irawebproject");

builder.Build().Run();
