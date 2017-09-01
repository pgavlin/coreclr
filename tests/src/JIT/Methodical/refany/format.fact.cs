using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _refany_format_format_
    {
        [OuterLoop]
        [Fact]
        public void _refany_format_format_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\format\\format.cmd");
        }
    }
}
