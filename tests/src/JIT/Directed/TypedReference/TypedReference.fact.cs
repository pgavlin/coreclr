using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _TypedReference_TypedReference_TypedReference_
    {
        [OuterLoop]
        [Fact]
        public void _TypedReference_TypedReference_TypedReference_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\TypedReference\\TypedReference\\TypedReference.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
