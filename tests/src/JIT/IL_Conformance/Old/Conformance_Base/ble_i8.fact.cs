using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ble_i8_ble_i8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ble_i8_ble_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ble_i8\\ble_i8.cmd");
        }
    }
}
