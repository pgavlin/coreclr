using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _PREFIX_unaligned_2_Box_Unbox_Box_Unbox_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_unaligned_2_Box_Unbox_Box_Unbox_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\unaligned\\2\\Box_Unbox\\Box_Unbox.cmd");
        }
    }
}
