using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _PREFIX_unaligned_2_initobj_initobj_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_unaligned_2_initobj_initobj_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\unaligned\\2\\initobj\\initobj.cmd");
        }
    }
}
