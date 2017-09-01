using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_deadcode_deadnonlocalexit_r_deadnonlocalexit_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_deadnonlocalexit_r_deadnonlocalexit_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\deadnonlocalexit_r\\deadnonlocalexit_r.cmd");
        }
    }
}
