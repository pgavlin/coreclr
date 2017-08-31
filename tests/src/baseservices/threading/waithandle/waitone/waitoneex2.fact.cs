using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _waithandle_waitone_waitoneex2_waitoneex2_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _waithandle_waitone_waitoneex2_waitoneex2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitone\\waitoneex2\\waitoneex2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
