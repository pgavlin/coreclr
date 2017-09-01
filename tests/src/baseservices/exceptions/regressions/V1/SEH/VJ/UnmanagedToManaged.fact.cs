using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _regressions_V1_SEH_VJ_UnmanagedToManaged_UnmanagedToManaged_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_VJ_UnmanagedToManaged_UnmanagedToManaged_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\VJ\\UnmanagedToManaged\\UnmanagedToManaged.cmd");
        }
    }
}
