using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _PREFIX_volatile_1_initobj_initobj_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_volatile_1_initobj_initobj_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\volatile\\1\\initobj\\initobj.cmd");
        }
    }
}
