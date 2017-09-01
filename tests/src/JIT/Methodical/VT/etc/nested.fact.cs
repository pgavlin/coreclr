using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _VT_etc_nested_nested_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc_nested_nested_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\nested\\nested.cmd");
        }
    }
}
