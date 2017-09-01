using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _waithandle_waitall_waitallex2_waitallex2_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _waithandle_waitall_waitallex2_waitallex2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitall\\waitallex2\\waitallex2.cmd");
        }
    }
}
