using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_cascadedcatchret_throwincascadedexcept_d_throwincascadedexcept_d_
    {
        [Fact]
        public void _eh_nested_cascadedcatchret_throwincascadedexcept_d_throwincascadedexcept_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\cascadedcatchret\\throwincascadedexcept_d\\throwincascadedexcept_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
