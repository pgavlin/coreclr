using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_ble_un_r8_ble_un_r8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ble_un_r8_ble_un_r8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ble_un_r8\\ble_un_r8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
