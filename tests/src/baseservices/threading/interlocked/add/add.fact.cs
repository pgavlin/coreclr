using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_add_add_add_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_add_add_add_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\add\\add\\add.cmd");
        }
    }
}
