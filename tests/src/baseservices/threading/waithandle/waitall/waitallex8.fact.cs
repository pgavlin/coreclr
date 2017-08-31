using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _waithandle_waitall_waitallex8_waitallex8_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _waithandle_waitall_waitallex8_waitallex8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitall\\waitallex8\\waitallex8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
