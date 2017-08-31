using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_cascadedcatchret_throwincascadedexceptnofin_d_throwincascadedexceptnofin_d_
    {
        [Fact]
        public void _eh_nested_cascadedcatchret_throwincascadedexceptnofin_d_throwincascadedexceptnofin_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\cascadedcatchret\\throwincascadedexceptnofin_d\\throwincascadedexceptnofin_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
