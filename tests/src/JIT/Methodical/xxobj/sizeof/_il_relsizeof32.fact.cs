using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_sizeof__il_relsizeof32__il_relsizeof32_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_sizeof__il_relsizeof32__il_relsizeof32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\sizeof\\_il_relsizeof32\\_il_relsizeof32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
