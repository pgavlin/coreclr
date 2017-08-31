using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_sizeof__speed_relsizeof__speed_relsizeof_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_sizeof__speed_relsizeof__speed_relsizeof_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\sizeof\\_speed_relsizeof\\_speed_relsizeof.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
