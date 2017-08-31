using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_sizeof__il_relsizeof__il_relsizeof_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_sizeof__il_relsizeof__il_relsizeof_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\sizeof\\_il_relsizeof\\_il_relsizeof.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
