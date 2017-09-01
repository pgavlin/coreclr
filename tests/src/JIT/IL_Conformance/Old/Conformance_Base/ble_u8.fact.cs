using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ble_u8_ble_u8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ble_u8_ble_u8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ble_u8\\ble_u8.cmd");
        }
    }
}
