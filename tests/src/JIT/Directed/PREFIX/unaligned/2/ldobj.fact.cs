using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _PREFIX_unaligned_2_ldobj_ldobj_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_unaligned_2_ldobj_ldobj_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\unaligned\\2\\ldobj\\ldobj.cmd");
        }
    }
}
