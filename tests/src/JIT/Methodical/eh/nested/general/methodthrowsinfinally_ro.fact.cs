using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_nested_general_methodthrowsinfinally_ro_methodthrowsinfinally_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_nested_general_methodthrowsinfinally_ro_methodthrowsinfinally_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\methodthrowsinfinally_ro\\methodthrowsinfinally_ro.cmd");
        }
    }
}
