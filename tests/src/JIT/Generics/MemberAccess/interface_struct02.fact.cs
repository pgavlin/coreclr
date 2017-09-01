using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _MemberAccess_interface_struct02_interface_struct02_
    {
        [OuterLoop]
        [Fact]
        public void _MemberAccess_interface_struct02_interface_struct02_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\MemberAccess\\interface_struct02\\interface_struct02.cmd");
        }
    }
}
