using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _PREFIX_unaligned_1_Box_Unbox_Box_Unbox_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_unaligned_1_Box_Unbox_Box_Unbox_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\unaligned\\1\\Box_Unbox\\Box_Unbox.cmd");
        }
    }
}
