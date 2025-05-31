using OpenShock.Common.ASPNET.Problems;

namespace OpenShock.Common.ASPNET.Errors;

public static class ExceptionError
{
    public static ExceptionProblem Exception => new ExceptionProblem();
}