using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _unittests_TryCatchInFinally_TryCatchInFinally_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_TryCatchInFinally_TryCatchInFinally_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\TryCatchInFinally\\TryCatchInFinally.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
