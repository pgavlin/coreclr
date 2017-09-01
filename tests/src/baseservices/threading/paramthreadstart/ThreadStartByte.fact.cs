using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _paramthreadstart_ThreadStartByte_ThreadStartByte_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartByte_ThreadStartByte_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartByte\\ThreadStartByte.cmd");
        }
    }
}
