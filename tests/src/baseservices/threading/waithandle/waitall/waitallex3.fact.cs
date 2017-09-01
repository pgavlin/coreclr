using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _waithandle_waitall_waitallex3_waitallex3_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _waithandle_waitall_waitallex3_waitallex3_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitall\\waitallex3\\waitallex3.cmd");
        }
    }
}
