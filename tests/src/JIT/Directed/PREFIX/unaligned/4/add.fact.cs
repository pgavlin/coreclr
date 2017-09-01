using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _PREFIX_unaligned_4_add_add_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_unaligned_4_add_add_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\unaligned\\4\\add\\add.cmd");
        }
    }
}
