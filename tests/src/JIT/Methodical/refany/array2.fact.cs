using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _refany_array2_array2_
    {
        [OuterLoop]
        [Fact]
        public void _refany_array2_array2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\array2\\array2.cmd");
        }
    }
}
