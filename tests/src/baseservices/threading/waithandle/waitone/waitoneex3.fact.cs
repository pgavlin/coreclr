using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _waithandle_waitone_waitoneex3_waitoneex3_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _waithandle_waitone_waitoneex3_waitoneex3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitone\\waitoneex3\\waitoneex3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
