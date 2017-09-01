using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ble_i4_ble_i4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ble_i4_ble_i4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ble_i4\\ble_i4.cmd");
        }
    }
}
