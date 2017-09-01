using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _waithandle_waitall_waitallex6_waitallex6_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _waithandle_waitall_waitallex6_waitallex6_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitall\\waitallex6\\waitallex6.cmd");
        }
    }
}
