using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _PREFIX_unaligned_4_ldobj_ldobj_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_unaligned_4_ldobj_ldobj_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\unaligned\\4\\ldobj\\ldobj.cmd");
        }
    }
}
