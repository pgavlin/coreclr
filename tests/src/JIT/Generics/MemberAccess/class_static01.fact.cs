using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _MemberAccess_class_static01_class_static01_
    {
        [OuterLoop]
        [Fact]
        public void _MemberAccess_class_static01_class_static01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\MemberAccess\\class_static01\\class_static01.cmd");
        }
    }
}
