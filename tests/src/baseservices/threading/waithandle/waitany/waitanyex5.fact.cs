using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _waithandle_waitany_waitanyex5_waitanyex5_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _waithandle_waitany_waitanyex5_waitanyex5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitany\\waitanyex5\\waitanyex5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
