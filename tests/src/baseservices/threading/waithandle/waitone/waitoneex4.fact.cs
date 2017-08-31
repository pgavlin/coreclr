using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _waithandle_waitone_waitoneex4_waitoneex4_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _waithandle_waitone_waitoneex4_waitoneex4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitone\\waitoneex4\\waitoneex4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
