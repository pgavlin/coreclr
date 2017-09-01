using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _PREFIX_unaligned_2_cpobj_cpobj_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_unaligned_2_cpobj_cpobj_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\unaligned\\2\\cpobj\\cpobj.cmd");
        }
    }
}
