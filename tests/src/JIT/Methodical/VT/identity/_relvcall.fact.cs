using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _VT_identity__relvcall__relvcall_
    {
        [OuterLoop]
        [Fact]
        public void _VT_identity__relvcall__relvcall_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\identity\\_relvcall\\_relvcall.cmd");
        }
    }
}
