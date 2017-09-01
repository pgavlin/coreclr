using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _threadstatic_ThreadStatic01_ThreadStatic01_
    {
        [OuterLoop]
        [Fact]
        public void _threadstatic_ThreadStatic01_ThreadStatic01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\threadstatic\\ThreadStatic01\\ThreadStatic01.cmd");
        }
    }
}
