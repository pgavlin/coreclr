using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _waithandle_waitany_waitanyex1_waitanyex1_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _waithandle_waitany_waitanyex1_waitanyex1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitany\\waitanyex1\\waitanyex1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
