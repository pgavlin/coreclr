using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _VT_etc__relctor_recurse__relctor_recurse_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__relctor_recurse__relctor_recurse_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_relctor_recurse\\_relctor_recurse.cmd");
        }
    }
}
