using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_sizeof__dbgsizeof__dbgsizeof_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_sizeof__dbgsizeof__dbgsizeof_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\sizeof\\_dbgsizeof\\_dbgsizeof.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
