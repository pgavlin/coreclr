using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_cascadedcatchret_throwincascadedexceptnofin_r_throwincascadedexceptnofin_r_
    {
        [Fact]
        public void _eh_nested_cascadedcatchret_throwincascadedexceptnofin_r_throwincascadedexceptnofin_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\cascadedcatchret\\throwincascadedexceptnofin_r\\throwincascadedexceptnofin_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
