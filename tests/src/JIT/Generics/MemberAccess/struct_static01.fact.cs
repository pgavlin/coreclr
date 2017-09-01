using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _MemberAccess_struct_static01_struct_static01_
    {
        [OuterLoop]
        [Fact]
        public void _MemberAccess_struct_static01_struct_static01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\MemberAccess\\struct_static01\\struct_static01.cmd");
        }
    }
}
