using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _ELEMENT_TYPE_IU__il_reli_flood__il_reli_flood_
    {
        [OuterLoop]
        [Fact]
        public void _ELEMENT_TYPE_IU__il_reli_flood__il_reli_flood_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\ELEMENT_TYPE_IU\\_il_reli_flood\\_il_reli_flood.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
