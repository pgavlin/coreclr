using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _waithandle_waitall_waitallex7_waitallex7_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _waithandle_waitall_waitallex7_waitallex7_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitall\\waitallex7\\waitallex7.cmd");
        }
    }
}
