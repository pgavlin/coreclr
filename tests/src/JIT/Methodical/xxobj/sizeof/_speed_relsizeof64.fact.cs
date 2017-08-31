using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_sizeof__speed_relsizeof64__speed_relsizeof64_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_sizeof__speed_relsizeof64__speed_relsizeof64_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\sizeof\\_speed_relsizeof64\\_speed_relsizeof64.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
