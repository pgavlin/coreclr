using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_leaves_leaveinsameregion_d_leaveinsameregion_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_leaveinsameregion_d_leaveinsameregion_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\leaveinsameregion_d\\leaveinsameregion_d.cmd");
        }
    }
}
