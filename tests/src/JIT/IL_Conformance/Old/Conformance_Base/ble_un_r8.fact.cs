using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ble_un_r8_ble_un_r8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ble_un_r8_ble_un_r8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ble_un_r8\\ble_un_r8.cmd");
        }
    }
}
