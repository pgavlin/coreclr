using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _waithandle_waitall_waitallex10_waitallex10_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _waithandle_waitall_waitallex10_waitallex10_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitall\\waitallex10\\waitallex10.cmd");
        }
    }
}
