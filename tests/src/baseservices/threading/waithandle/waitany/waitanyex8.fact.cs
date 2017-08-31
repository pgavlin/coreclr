using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _waithandle_waitany_waitanyex8_waitanyex8_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _waithandle_waitany_waitanyex8_waitanyex8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitany\\waitanyex8\\waitanyex8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
